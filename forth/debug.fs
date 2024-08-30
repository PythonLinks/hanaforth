    \ : t1 dup . dup 2 * @ . cr  ;
    \ : test cr 5 0 do I t1 loop ;
    \ Show where flash and RAM differ. 
    \ : both dup dup @ swap  787 load ;  ( addr -- 2*addr @2*addr Flash@addr )
     \ : diff  2 * both
	 <> if
	   dup  .   both . . drop cr     ( ___ --  2*addr, flash, ram )  
	 else drop then  ;
     
    \ : comp 8191 0 do I diff loop ." DONE " cr ;
			       

     : it 1000 0 do I dup decimal . 2 * dup  . @ . cr loop ;  

     : lines dup . cr   ;

     \ SIMPLE WORKS
     \ : show decimal dup . hex @ . . cr ;

     : show decimal   ( value addr )
	 2dup          ( value addr value addr )
	 @             ( value addr value value2 )
	 <>
	 if            ( value addr )
	 dup           ( value addr addr )
	 @             ( value addr value )
	 swap          ( value value addr ) 
	 hex . . . cr
	 else
	 decimal .    
         drop
	 then
	 ;