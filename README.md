# DiscriminatedUnionCompilerBug

The constructors for ClassCOrClassD give error 
CS1520  Method must have a return type when in a different project than OneOf class

The same basic code in ClassAOrClassB compiles cleanly because it is in the same
project as the OneOf<> class.

The files ClassA and ClassC are the same code with a different class name.
The files ClassB and ClassD are the same code with a different class name.
The files ClassAOrClassB and ClassCOrClassD are the same with different class names.

To confirm that the error is caused by which libarty the code is in:
Copy files
   ClassC.cs
   ClassD.cs
   ClassCOrClassD.cs
from "ADifferentLibrary" project to "DiscriminatedUnion" project
and it will compile without an error.

