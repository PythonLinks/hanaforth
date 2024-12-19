# Hana-1: Programmable I/O for FPGAs

Hana-1 îs a programable soft core I/O processor for FPGAs. Instead of designing a circuit, just program your desired I/O functionality.  

This repository contains both a [simulator for the Hana 1](./simulator), and a number of gatewares for the [p(https://tinyvision.ai/products/pico-ice-fpga-trainer-board).


[Documentation](https://mecrisp-ice.readthedocs.io/en/latest/instruction-set.html)

The bootloader is a small modification of
[Mecrisp-pi](https://github.com/PythonLinks/mecrisp-pi).  The
simulator is for the more advanced Hana-1 cpu.  Hana-1 includes, SPI
access, a better bus, code folding, and a richer library, but requires
119 fewer LUTs, The J1a is larger because it implements the stacks in
BRAMs. and requires a multiplexer to connect together 32 x 4Kbit block
RAMs (BRAMs) into a single 8K word memory module.  The Hana 1 is
smaller because it implements the data and return stack in 2 BRAMs,
and uses a 16K word hardcore single port RAM (SPRAM) to provide the
bulk of the memory. The J1a cannot use the larger SPRAMs available on
the more modern ICE40-UP FPGAs because the SPRAMs cannot be
initialized in the bitstream, they require a bootloader.  Hana 1
includes one BRAM initialized with a compute kernel, a boot loader,
and uses 2 BRAMs for stacks, freeing up 27 other BRAMs for other uses.
Would you like more stacks with your Forth anyone?

The Mecrisp Hayes Forth test suite was modified to run on the FPGA,
and the system passed all tests.  You can read more about the system
in an article and a Master's thesis, hosted on a private channel on
the pico-ice discord server.  As soon as the publication ban expires
in October 2024, the article will be posted here.

The Hana 1 was built by modifying the dual port Mecrisp Ice Verilog
and Forth.  Mecrisp Ice is built on top of SwapForth.

TODO:

1. Get the boot script working on the FPGA.  Eventually, the pico-ice gateware will also be hosted here.

2. There are some Mecrisp tests that use an undefined word. I need to figure out what is going on there.

3. The Hayes (ANSI) Forth test suite allows, even causes stack overflow and underflow, Hana 1 is stricter. I am not quite sure what to do.

4. There are some additional compile switches I want to add.
   -static -static-libgcc -static-libstdc++ LDFLAGs

5. Add a beautiful makefile like [this one](https://github.com/XarkLabs/upduino-example/blob/master/Makefile#L147-L153).

6. Get the boot script working on the FPGA. 

