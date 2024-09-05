# Pico Ice Bitstream

This directory will (hopefully soon) contain a bitstream for the
pico-ice, and tools to create your own customized version.  When it is
available, when you are building the bitstream, you will call the not
yet existing command

./flash

Which will then call

../simulator/compile

You will then have to drag a file with code to be boot loaded onto the
pico-ice folder.  That gets downloaded to the RP2040, which unpacks it,
reads the target address on the FLASH, and copies it to that address.
You can then log in to pico ice with your terminal emulator.  Sadly there is a
firmware bug when connecting to the board with with Mac OS.  With Linux best to connect to the board with e4thcom.  You can read [how to use E4thcom with Hana-1]{https://mecrisp-ice.readthedocs.io/en/latest/e4thcom.html).

