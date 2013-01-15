namespace I {
	class A {
	  A a;
	  
	  A a() {
	    return a;
	  }
	}
	
	class B : A {
    A b() {
      return a;
    }
	} 
	
	class C : B {
    A c() {
      return a.a();
    }
	}
}