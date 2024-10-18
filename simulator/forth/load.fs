: load
spiStart
nop

\ 30 hex read instruction transposed

spi! nop nop nop
nop  nop nop nop
nop  nop nop nop
nop  nop nop nop

spi! nop nop nop
nop  nop nop nop
nop  nop nop nop
nop  nop nop 

spi@ drop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop
nop    
nop
spi@
spiEnd
nop
;






