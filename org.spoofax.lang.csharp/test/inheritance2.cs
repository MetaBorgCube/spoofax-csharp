namespace I2 {
  partial class A {
	  int inherited() {
	    return 1;
	  }
	} 
	
	partial class B : A {
	  int test() {
	    return inherited(); 
	  }

    // TODO: Fix overriding
	  /*
	  string inherited(string x) {
	    return x;
	  }
	  */
	  
    int inherited(int x) { 
      return x + 1;
    }
	} 
	
	partial class C : B {
	  int inherited(int x) { 
	    return inherited() * 2;
	  }
	}
	
	partial class Foo {
	  C c;
	  
	  int foo() {
	    return c.inherited("x");
	  }
	}
}