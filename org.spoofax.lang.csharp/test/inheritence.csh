namespace Inheritance {
	class C  {
	  int inherited() {
	    return 2;
	  }  
	} 
	
	class B : C {
	  int inherited() {
	    return 1;
	  }
	}
	
	class A : B {
	  int test() {
	    return inherited();
	  }
	}
}