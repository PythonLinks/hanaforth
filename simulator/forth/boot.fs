decimal 

    
: loader \ (addr)
    dup  \ (addr addr)  For Looping and Storing
    dup  \ (addr addr addr) Looping, saving reading.
    787    \ (addr addr addr 0313) 0313 in decimal.
    load   \ (addr addr  valueF1) Shift out and in
    swap   \ (addr valueFl addr)

     \ 2dup
     \ show
     !! drop
         
    2      \ (addr 2)
    +      \ (addr+2)
    dup    \ (addr+2 addr+2)
    16383   \ (addr+2 addr+2  number) Loops
    <      \ (addr+2 Bool) N < T
    if     \ (addr+2)
    15994   \  Jump address
    >r	
    exit   \ (addr+2) ITERATE
    then   \
    drop   \ () clear the stack
    ;

    : boot 0 loader
    0      \ (0) set the boot address
    >r     \ () Put it on the return stack
    ;

