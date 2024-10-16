
\ shows all
\ : show decimal dup . @ .x .x cr ;    
\ : show decimal dup dup . .x @ .x .x cr ;    
\ shows errors
 : show decimal   \ value addr
    2dup      \ value addr value addr
    @         \ value addr value value2
    =         \ value addr  bool
    if drop drop
    else dup ." ERROR: " dup 2/ . .x @ .x .x  cr
    then
    ;


