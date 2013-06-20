namespace MethodCall {
	class C {
	  int i;
	  int get() { return i; }
	}
	
	class D {
	  C c;
	  int i;
	  void init() {
	    i = c.get();
	  }
	}
}