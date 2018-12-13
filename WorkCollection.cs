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

		public new IEnumerator<T> GetEnumerator() {
			return (IEnumerator<T>) List.GetEnumerator();
		}

		public void Sort(Func<T, T, bool> res) {
			bool mySort = true;
			do {
				mySort = false;
				for (int i = 0; i < List.Count - 1; i++) {
					if (res((T) List[i + 1], (T) List[i])) {
						T j = (T) List[i];
						List[i] = List[i + 1];
						List[i + 1] = j;
						mySort = true;
					}
				}
			} while (mySort);
		}
	}
}