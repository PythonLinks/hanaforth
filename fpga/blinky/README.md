# MECRISP ICE BLINKY


This gateware blinks the lights. A blinky is useful to reset the FPGA,and make sure that you are downloading a new program.

To install it:

::
   Linux
   sudo dfu-util -a 1 -D blinky.bin

   Mac OS
   dfu-util -a 1 -D blinky.bin   

Or you can reconfigure linux to allow access to the
ports without a password. 