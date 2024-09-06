
  include ../common-forth/nucleus-16kb.fs

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
