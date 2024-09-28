# Mecrisp Ice J1a Gateware for the Pico Ice

This is the Mecrisp Ice version of a pseudo dual port J1a.  This is a
bitstream which you can download and run on the pico ice. The data and return stacks are 16 deep.

Git clone and change into the directory.

```
git clone https://github.com/develone/hanaforth.git -b dev

cd hanaforth/fpga/j1a/
```

Then flash the bitstream. 

Mac OS 

```
   dfu-util -a 1 -D j1a.bin
```

On Linux you will need sudo.

```
   sudo dfu-util -a 1 -D j1a.bin
```

When you first start out, it is easiest to use the picocom
terminal emulator.

```
sudo picocom --baud 115200 --imap crcrlf,lfcrlf /dev/ttyACM1
```
If you are doing a lot of work, it is recommended that you use the
[e4thcom terminal
emulator](https://mecrisp-ice.readthedocs.io/en/latest/e4thcom.html)

To build it yourself, first [download Mecrisp Ice
2.6d](https://sourceforge.net/projects/mecrisp/files/).  The newer
versions of Mecisp Ice lack a license agreement.

Then install the [pico ice directory](https://sourceforge.net/p/mecrisp/discussion/general/thread/350a65f919/) into the Mecrisp Ice directory.

Here is the Utilization Report.

Info: 	         ICESTORM_LC:    2970/   5280    56%
Info: 	        ICESTORM_RAM:      30/     30   100%
Info: 	               SB_IO:       4/     96     4%
Info: 	               SB_GB:       6/      8    75%
Info: 	        ICESTORM_PLL:       0/      1     0%
Info: 	         SB_WARMBOOT:       0/      1     0%
Info: 	        ICESTORM_DSP:       0/      8     0%
Info: 	      ICESTORM_HFOSC:       0/      1     0%
Info: 	      ICESTORM_LFOSC:       0/      1     0%
Info: 	              SB_I2C:       0/      2     0%
Info: 	              SB_SPI:       0/      2     0%
Info: 	              IO_I3C:       0/      2     0%
Info: 	         SB_LEDDA_IP:       0/      1     0%
Info: 	         SB_RGBA_DRV:       0/      1     0%
Info: 	      ICESTORM_SPRAM:       0/      4     0%