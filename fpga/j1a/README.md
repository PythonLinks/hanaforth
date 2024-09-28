# Mecrisp Ice J1a Gateware for the Pico Ice

This is the Mecrisp Ice version of a pseudo dual port J1a.  This is a
bitstream which you can download and run on the pico ice. The data and return stacks are 16 deep.

```
git clone https://github.com/develone/hanaforth.git -b dev

cd hanaforth/fpga/j1a/
```

Then flash the bigstream. 
```
   Mac OS 
   dfu-util -a 1 -D j1a.bin

   On Linux you will need sudo.
   sudo dfu-util -a 1 -D j1a.bin
```

When you first start out, it is easiest to use the picocom
terminal emulator.

sudo /home/devel/picocom/picocom --baud 115200 --imap crcrlf,lfcrlf /dev/ttyACM1

If you are doing a lot of work, it is recommended that you use the [e4thcom terminal emulator](https://mecrisp-ice.readthedocs.io/en/latest/e4thcom.html)

To build it yourself, first [download Mecrisp Ice
2.6d](https://sourceforge.net/projects/mecrisp/files/).  The newer
versions of Mecisp Ice lack a license agreement.

Then install the [pico ice directory](https://sourceforge.net/p/mecrisp/discussion/general/thread/350a65f919/) into the Mecrisp Ice directory.
