namespace I {
	class A {
	  A a;
	}
	
	class B : A {

	}
	
	class C : B {
    void b() {
      return a;
    }
	}
} 