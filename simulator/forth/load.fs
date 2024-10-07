: load
spiStart
nop

\ 30 hex read instruction transposed

spi! \ spi! sets cs+
    nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop

spi! nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop drop

spi@ nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop
spi@
spiEnd
nop
;






