using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace NI_imp
{
    class DAQ_NI
    {
        
        //set Analog AO0 - voltage level
        public void set_voltage_AO(double volt_AO)
        {
            using (Task myTask = new Task())
            { 

            AOChannel myAOChannel;
            myAOChannel = myTask.AOChannels.CreateVoltageChannel("dev1/ao0", "myAOChannel", 0, 5, AOVoltageUnits.Volts);
            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(myTask.Stream);
            writer.WriteSingleSample(true, volt_AO);
           }
        }

        //read Digital Input(port0) - input
        public uint reading_DI(string device, string port_name)
        {
            UInt32 dataDI = 0;

            Task digitalReadTask = new Task();

            digitalReadTask.DIChannels.CreateChannel(device, port_name, ChannelLineGrouping.OneChannelForAllLines);
            DigitalSingleChannelReader reader = new DigitalSingleChannelReader(digitalReadTask.Stream);
            dataDI = reader.ReadSingleSamplePortUInt32();
            return dataDI;
        }
      
        //write Digital Out(port0|) - out value decimal value to bin 
        //(1 - 0000 0001, 2 - 0000 0010, 3 - 0000 0011, 4 - 0000 0100, 5 - 0000 0101, 8 - 0000 1000)
        //(64 - 0100 0000, 32 - 0010 0000)
        //(255 - 1111 1111) 
        public void writing_DO(string device, string port_name, uint val)
        {
            UInt32 dataDO = val;

            Task digitalWriteTask = new Task();
            
            //  Create an Digital Output channel and name it.
            digitalWriteTask.DOChannels.CreateChannel("dev1/port0", "port0", ChannelLineGrouping.OneChannelForAllLines);
            //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
            //  of digital data on demand, so no timeout is necessary.
            DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
            writer.WriteSingleSamplePort(true, (UInt32)dataDO);
        }
    }
}
