namespace ImplicitDef {
	class A {
	  void test() {
	    this.test();
	  }
	}
	
	class B : A {
	  void test() {
	    super.test();
	  }
	}
}