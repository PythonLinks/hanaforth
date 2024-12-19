# BOOTlOADER

This directory holds a bootloader.  It is a modified mecrisp-pi
gateware.

```boot0``` reloads the default bootloader. 

```boot1``` loads a different gateware

```boot2``` and ```boot3``` would also work if there were anything
there.

You can distinbuish the two gatewares by their titles

Mecrisp-Ice 2.6 b
Mecrisp-Ice 2.6

The ```b``` stands for bootloader. 
The first one is the bootloader.
Also the commands `boot0`, `boot1`, and 
`see boot0` only works in the bootloader.

It is quite easy to add a different gateware.
Just edit the `compile` command file.

The "./dfu" command flashes the device.
