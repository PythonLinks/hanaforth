# LICENSE

The Hana 1 processor is a variant of Mecrisp Ice 2.6d, which is a
variant of swapforth.  (Mecrisp Ice 2.6e does not have a license.)
Both SwapForth and Mecrisp Ice 2.6d are based on the FreeBSD 3 clause
license.  So the underlying Verilog is only subject to the FreeBSD
3 clause license.

Both SwapForth and Mecrisp Ice use gForth to do cross compiling.  And
the cross compiled code will soon be included in the gateware.  So the
Forth code is subject to the FreeBSD license, but it may also be
subject to the GPL license.  That depends on whether any part of
gForth is included in the cross compiled code.  Since the cross compiler
is so difficult to understand, I am not yet sure of the answer.

I am not a lawyer, this is not legal advice.

