// Hierarchy = 階層
public class OpenTypeHierarchy {
	public class ParentClass {
		public void parentMethod() {
			System.out.println("This is the parent class");
		}
	}
	// F4
	public class ChildClass extends ParentClass {
		@Override
		public void parentMethod() {
			System.out.println("This is the child class.");
		}
	}
}
