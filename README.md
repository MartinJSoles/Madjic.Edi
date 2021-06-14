# Madjic.Edi
Strongly typed ANSI X12 5010 version HIPAA objects for parsing and generating healthcare related documents.

This project used the official ANSI X12 databases to generate the original source code. I'm opening this project up for others to use and modify as they see fit.

When reading, you would use the static methods on the `Madjic.Edi.Dom.Document` class to get started. The stream passed in will be parsed into the EDI structures of Envelopes,
Functional Groups, and Transaction Sets.

When creating, you would use the static methods on the desired transaction sets in the `Madjic.Edi.Dom.Factory.*` namespaces. You will notice that these methods all return
objects that implement the specific interface.

Internally, there are single classes used for all implementations of each segment. For example, there is an internal class named `REF_Obj`. This class implements a large number
of interfaces, one for each distinct use. The same is true for transaction sets and individual loops (in the 837 professional there are a number of 2310 loops, they are all backed
by a single class definition).

## Known Issues
1. There is no code in place to properly handle the repeating elements (such as the EB03 element).
