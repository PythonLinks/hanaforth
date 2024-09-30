# The Hana 1 Soft Core

This repository contans a [simulator for the Hana 1](./simulator), 
soft core stack machine running a small interpreter and compiler
in simulation. 

Hana 1 is the newest member of the J1 family of stack processors. Hana
1 provides 16K 16 bit words of memory.  Compared to the popular J1a,
the Hana 1 has twice the memory, much larger stacks (256 vs 16 words),
[more hardware
instructions](https://mecrisp-ice.readthedocs.io/en/latest/instruction-set.html),
SPI access, a better bus, code folding, and a richer library, but
requires 119 fewer LUTs, The J1a is larger because it requires a
multiplexer to connect together 30 x 4Kbit block RAMs (BRAMs) into a
single 8K word memory module.  The Hana 1 is smaller because it uses a
16K word hardcore single port RAM (SPRAM) to provide the bulk of the
memory. The J1a cannot use the larger SPRAMs available on the more
modern ICE40-UP FPGAs because the SPRAMs cannot be initialized in the
bitstream, they require a bootloader.  Hana 1 includes one BRAM
initialized with a compute kernel, a boot loader, and uses 2 BRAMs for
stacks, freeing up 27 other BRAMs for other uses.
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

