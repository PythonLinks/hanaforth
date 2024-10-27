
# Pico Ice Echo Server

This page describes the pico-ice echo server, which is used to debug
passing text from the USB through the RP2040 and to the FPGA.

On the Pico-ice the USB talks to the RP2040, which talks to the Ice40
FPGA.  This is called a pass through.  It works in C, but needs to be
implemented in other languages on the RP2040, such as ZeptoForth and
MicroPyhon.  To implement it and debug it, one needs an echo server
running on the FPGA.

This echo server flashes green every 3 seconds.  This is so that you
know that it is installed correctly.  When you send text to the echo
server, it flashes white, once for each character typed, and is echoed
back.  Best to type text in between the green flashes.

The gateware beta version is available on the discord server.  To
flash the gateware first install dfu-util

dfu-util -a 1 -D echo.bin

To talk to the FPGA, use picocom.

First you have to find the usb devices.  On Mac OS X I did

ls /dev | grep usb

and chose the second tty

picocom --omap crcrlf /dev/tty.usbmodem103

The omap option converts the keyboard carriage return into a carriage return and line feed.

So far, I am the only person who has used it.  So to make sure it
works correctly for you, first test it using the most recent RP2040
firmware, then use it with whatever language you are developing for.
