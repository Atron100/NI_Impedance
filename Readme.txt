database configuration, main feature application work.


1. main file is mouse test info


2. Operation file:

N, Time, Frequency, SS, Pause

N - line number
Time - duration in milisec
Frequency - frequency of 1 VPtP Sinewave output from one of analog outputs of NI DAQ, 0 - mean no output.
Frequence range will be 1 to 100KHz
SS - 40 bit binary string
Pause - puse in milisec between the end of this cycle to the begining of the next cycle.
-----------------------------------------------------------------------------------------------------------------------------


3. Save data to "SI_signalsN.csv" file 

4. Calculate the complex impedance from the PtP amplitude of the voltage recorded from 
signal analog input and the phase angle between the voltages at the signal input to the voltage at the
reference input
Calculation will include only the signal between 10% to 90% of the Time cycle.

Append data output csv file with name "SI_data.csv" with a new line as follows:

N, Time, Frequency, SS, Zreal, Zimg

N - line number
Time - duration of cycle in milisec
Frequency - frequency of excitation
SS - 40 bit binary string
Zreal - the real prt of calculated impedance
Zimg - the imaginary part of calculated impedance