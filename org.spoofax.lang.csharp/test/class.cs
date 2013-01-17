namespace Simple {
	partial class A {
	  A a;
	  A ab;
	  A abc;
	  
	  A bla() {
	    return a.a.abc.lol(); 
	  }
	}
	
	partial class A {
    A lol() {
      return a;
    }
	}
}  