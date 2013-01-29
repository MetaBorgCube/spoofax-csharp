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

	  string inherited(string x) {
	    return x;
	  }
	  
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
	  
	  string foo() {
	    c.inherited(1);
	    
	    return c.inherited("x"); 
	  }
	}
}