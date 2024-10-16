
\ shows all
\ : show decimal dup . @ .x .x cr ;    

\ shows errors
: show decimal   \ value addr
    2dup      \ value addr value addr
    @         \ value addr value value2
    =         \ value addr  bool
    if drop drop
    else dup ." ERROR: " .x @ .x .x  cr
    then
    ;

