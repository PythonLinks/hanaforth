
  include ./nucleuslib.fs

\ -----------------------------------------------------------------------------
\  Boot here
\ -----------------------------------------------------------------------------

: main
    dint     \ Disable interrupts
    welcome   \ Emit welcome message
    quit
;

meta
    link @ t' forth tw!
    there  t' dp tw!
target
