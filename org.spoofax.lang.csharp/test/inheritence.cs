namespace I {
	class A {
	  A a;
	}
	
	class B : A {
    A b() {
      return a;
    }
	} 
	
	class C : B {
    A b() {
      return a;
    }
	}
}