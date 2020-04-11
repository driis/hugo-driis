+++draft = false
date = 2012-10-05T17:05:10.0641430
title = "What is TypeScript and why should I care ? "
slug = "what-is-typescript"
+++
This tuesday, I watched Anders Hejlsberg present Microsoft's new language bet, [TypeScript][1]. This is basically JavaScript with types. It compiles to JavaScript, so, at runtime, it _is_ JavaScript, nothing else. And therefore, it will run whereever JavaScript can run: In any browser, on node.js and so on.

TypeScript adds types as a first class citizen to JavaScript. This means you can use classes and interfaces in your code, and have the compiler do type checking. TypeScript is compiled to the idiomatic JavaScript, we would have to write ourselves, if we want to do object oriented programming in JavaScript. It also adds modules, and a bit nicer anonymous function syntax. Already available is some really nice tooling for Visual Studio 2012. 

This is an example of how a snippet of TypeScript looks:

    class Greeter {
    	greeting: string;
    	constructor (message: string) {
    		this.greeting = message;
    	}
    	greet() {
    		return "Hello, " + this.greeting;
    	}
    }   
    
    var greeter = new Greeter("world");
    var greeting = greeter.greet();




Why should I care ?
==

We are building larger and larger applications in JavaScript. This is true both to support great user experiences on the web, but JavaScript is also used more and more for many other purposes: You can create standalone applications or servers in node.js, you can use HTML+JavaScript for Windows 8 programs and other platforms. The lack of types in JavaScript means that development and debugging time can be slowed down, and bugs can be hard to find.

You might not agree with this, but consider: 

* Have you ever misspelled a method in JavaScript, and not found out until that exact method ? This does not happen with TypeScript.
* Ever had to look some method signature up in the jQuery documentation, then spending time on Google to find the right one - with the TypeScript tools, you get auto completion right in the editor (Visual Studio for now).

Basically you get all the safety nets of a statically typed language, while still having all the benefits from JavaScript. The static typing also allows for features like auto-completion and refactoring support. One of the core benefits from using TypeScript is added tool support, and in turn, developer productivity.  

Is this not just a rip-off of CoffeeScript ? 
==
No, I don't think so. CoffeeScript is about fixing the syntax of JavaScript, but it does not touch the type system. This is the core difference betweeen the two. You might like or dislike the CoffeeScript syntax, but the CoffeeScript compiler is not aware of types.

I think TypeScript does a good job of keeping a familiar syntax, while reducing the amount of typing needed to create, for instance, a class. TypeScript also does automatic capture of the `this` variable for anonymous functions, which is very neat.

Go try it out
==
You can download the bits for VS or node.js [here][2], and there is also an [online playground][3], where you can run TypeScript directly in your browser. It's a preview, but is seems pretty stable to me.

Maybe it is not for you, maybe you are the dynamic language type of guy - But, I am excited about this and for fans of static typing, this is great news. 

I might even get excited about the prospect of building a node.js app now.


  [1]: http://www.typescriptlang.org/
  [2]: http://www.typescriptlang.org/#Download
  [3]: http://www.typescriptlang.org/Playground/
