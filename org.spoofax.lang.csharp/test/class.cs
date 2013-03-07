namespace Simple {
	partial class FancyA {
	  FancyA a;
	  FancyA ab;
	  FancyA abc;
	   
	  FancyA bla() {
	    return a.ab.abc.lol(); 
	  }
	}
	
	partial class FancyA {
    FancyA lol() {
      return a;
    }
	}
}