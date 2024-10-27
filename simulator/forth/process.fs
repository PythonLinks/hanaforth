\ THIS IS A SECOND BOOT APPLICATION
\ JUST CONTINUOUSLY READ FROM THE FLASH. 
\ EVERY 16 CYCLES

decimal 

: process \ (addr)
    spi@  \  addr  value
    over  \ addr value addr
    !!
    drop         
    2      \ (addr 2)
    +      \ (addr+2)
    dup    \ (addr+2 addr+2)
    16382   \ (addr+2 addr+2  number) Loops
    <      \ (addr+2 Bool) N < T
    if     \ (addr+2)
    15990   \  Jump address hex 3E76
	>r
	nop
	nop
	nop
    exit   \ (addr+2) ITERATE
    then   \
    drop   \ () clear the stack
    ;

    : boot
    0 
    dup  \ (addr addr)  For Looping and Loading
    787    \ (addr addr 0313) 0313 in decimal.
    start   \ addr 	
    process   \ (addr ) Shift out and in
	
    0      \ (0) set the boot address
    >r     \ () Put it on the return stack
    ;

