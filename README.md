# The Hana 1 Soft Core

This repository contains a verilator-based simulator for the Hana 1
Forth stack machine soft core. Eventually the gateware for the
pico-ice will also be hosted here. 

Hana 1 is the newest member of the J1 family.  Compared to the popular
J1a, the Hana 1 has twice the memory, much larger stacks, more
hardware instructions, SPI access, a better bus, code folding, and a
richer library, but requires 119 fewer LUTs, The J1a is larger because
it requires a multiplexer to connect together 30 x 4Kbit block RAMs
(BRAMs) into a single memory module.  The Hana 1 is smaller because it
uses a 16K word hardcore single port RAM (SPRAM) to provide the bulk
of the memory. The J1a cannot use the larger SPRAMs available on the
more modern ICE40-UP FPGAs because the SPRAMs cannot be initialized in
the bitstream, they require a bootloader.

Available memory was expanded from 8K words to 16K words.  27x4Kbit Block RAMs (BRAMs) were freed up for other uses.  119 LUTs were saved.   The Mecrisp Hayes Forth test suite was modified to run on the FPGA, and the system  passed all tests.  A simulator for Mac and Linux and gateware for the Pico Ice are available on github.  

The Hana 1 was built by modifying the dual port Mecrisp Ice Verilog
and Forth.  Mecrisp Ice is built on top of SwapForth.

To compile the forth run

./compile

to run the emulator then type

./emulate

To run the tests type 

./runtests 

Compiling is a two stage process.  First gforth is used to compile a
nucleus.  The nucleus is enough to boot the system.  Then the
remaining code is loaded into the simulator, and exported to
build/iceimage.hex.  Then the emulator can be run.  When you run the
simulator it has two arguments.

-halt will halt on overflow or underflow.  This should be used during
development, but now when running the test suite.

-trace will run the tracing.   It creates a file signal.fst which can then
be viewed by typing

gtkwave signal.gtkw

The escape key can be used to leave the simulator, but preserve the
trace functionality.

Eventually, the pico-ice gateware will also be hosted here.

TODO:

1. There are some Mecrisp tests that use an undefined word. I need to figure out what is going on there.
2. The Hayes (ANSI) Forth test suite allows, even causes stack overflow and underflow, Hana 1 is stricter. I am not quite sure what to do.
3. There are some additional compile switches I want to add.
   -static -static-libgcc -static-libstdc++ LDFLAGs
4. Get it boot script working on the FPGA. 