namespace I {
	class FancyA {
	  FancyA a;
	  
	  FancyA a() {
	    return a;
	  }
	}
	
	class FancyB : FancyA {
    FancyA b() {
      return a;
    }
	} 
	
	class C : FancyB {
    FancyA c() {
      return a.a();
    }
	}
}