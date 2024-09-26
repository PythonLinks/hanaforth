# Mecrisp Ice J1a Gateware for the Pico Ice

This is the Mecrisp Ice version of a pseudo dual port J1a.   This is a bitstream which you can download and run on the pico ice.



To flash the gateware type:

::

   Mac OS 
   dfu-util -a 1 -D j1a.bin

   On Linux you will need sudo.
   sudo dfu-util -a 1 -D j1a.bin

It is recommended that you use the [e4thcom terminal emulator](https://mecrisp-ice.readthedocs.io/en/latest/e4thcom.htm)

To build it yourself, first [download Mecrisp Ice
2.6d](https://sourceforge.net/projects/mecrisp/files/).  The newer
versions of Mecisp Ice lack a license agreement.

Then install the [pico ice directory](https://sourceforge.net/p/mecrisp/discussion/general/thread/350a65f919/) into the Mecrisp Ice directory.
