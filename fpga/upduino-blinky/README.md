# UPDUINO BLINKY

This gateware blinks the lights. A blinky is useful to reset the
FPGA,and make sure that you are downloading a new program.

To install it:

```
   sudo iceprog -d i:0x0403:0x6014 blinky.bin

```

Or you can reconfigure linux to allow access to the
ports without a password.
