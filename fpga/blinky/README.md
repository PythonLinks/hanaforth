# BLINKY

A blinky is useful to reset the FPGA, and make sure that you are downloading
a new program.

dfu-util -a 1 -D blinky.bin

On Linux you will need to do

sudo dfu-util -a 1 -D blinky.bin

Or you can configure linux to allow access to the ports. 