open System
let verbatimXml = @"<book title=""Paradise Lost"">"
let tripleXml = """<book title="Paradise Lost">"""
Console.Write(verbatimXml)
Console.Write(tripleXml)
let poem = 
    "\nThe lesser world was daubed\n\
     By a colorist of modest skill\n\
     A master limned you in the finest inks\n\
     And with a fresh-cut quill."
Console.Write(poem)