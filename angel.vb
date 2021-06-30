module condicional
sub main()
dim a, b as integer
While True
system.console.write("primer numero:")
A=system.console.readline() 
system.console.write("segundo numero:")
B=system.console.readline() 
'condicional
if a>b then
system.console.writeline("el Mayor es:" & a)
else
system.console.writeline("El Mayor es:" & b)
end if
system.console.readline()
end while
end sub
end module

 