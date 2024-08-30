: save
\ Because the chipselect register may not be zeroed    
\ spi! sets cs+
cs-
    
\ 20h store instruciton transposed    
02

spi! nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop

spi! nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop

spi! nop nop nop
nop nop nop nop
nop nop nop nop
nop nop nop nop
cs-
;
