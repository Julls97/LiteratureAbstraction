using System;
using System.Collections;
using System.Collections.Generic;

namespace LiteratureAbstraction {
	public class WorkCollection<T> : CollectionBase, ICollection<T> where T : Work {
		public void Add(T item) {
			if (item != null)
				List.Add(item);
		}

		public bool Contains(T item) {
			return item != null && List.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex) {
			List.CopyTo(array, arrayIndex);
		}

		public bool Remove(T item) {
			try {
				List.Remove(item);
				return true;
			}
			catch (NotSupportedException) {
				return false;
			}
		}

		public bool IsReadOnly { get; }

		public new IEnumerator<T> GetEnumerator()
		{
			foreach (T o in this.List)
				yield return o;
		}

		public T this[int i] {
			get { return (T) List[i]; }
			set { List[i] = value; }
		}	
	

		public void Sort(Func<T, T, bool> res) {
			bool mySort;
			do {
				mySort = false;
				for (int i = 0; i < Count - 1; i++) {
					if (res(this[i + 1], this[i])) {
						T j = this[i];
						this[i] = this[i + 1];
						this[i + 1] = j;
						mySort = true;
					}
				}
			} while (mySort);
		}

		public delegate bool SelectDelegate(T item);
		
		public WorkCollection<T> Select(SelectDelegate selectDelegate) {
			WorkCollection<T> workCollection = new WorkCollection<T>();
			foreach (var item in this) {
				bool isSelect = selectDelegate(item);
				if(isSelect) workCollection.Add(item);
			}

			return workCollection;
		}

		public void ChangeAll(Action<T> action) {
			for (int i = 0; i < this.Count; i++) {
				action(this[i]);
			}
		}
	}
}