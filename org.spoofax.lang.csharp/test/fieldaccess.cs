namespace FieldAccess {
	class C {
	  int i;
	}
	
	class D {
	  C c;
	  int i;
	  void init() {
	    i = c.i;
	  }
	}
}