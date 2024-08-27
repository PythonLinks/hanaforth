
\ #######   MEMORY   ##########################################

: unused
    $4000 here -
;

here .

: now   ( -- ) 0 $4000 io! ;
: ticks ( -- u ) $4000 io@ ;
: delay ( u -- ) begin dup ticks u< until drop ;
