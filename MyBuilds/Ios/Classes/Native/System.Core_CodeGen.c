#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskExtensions::Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task`1<TResult>>)
// 0x00000002 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000003 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000004 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000005 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000006 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000007 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000008 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000009 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Take(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::TakeIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000000E System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000F System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x00000010 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000012 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Reverse(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000013 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::ReverseIterator(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000014 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000016 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000017 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000018 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000019 TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001A TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001B TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000001C System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Empty()
// 0x0000001D System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001E System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001F System.Boolean System.Linq.Enumerable::All(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000020 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000021 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000022 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000023 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000024 System.Int32 System.Linq.Enumerable::Min(System.Collections.Generic.IEnumerable`1<System.Int32>)
extern void Enumerable_Min_mF7108B5155FD1BC3BBD32511DCD8A0385EEEED9E (void);
// 0x00000025 System.Int32 System.Linq.Enumerable::Max(System.Collections.Generic.IEnumerable`1<System.Int32>)
extern void Enumerable_Max_mE02EED2C10C2F8F0B2DCE468C87EF3064E854A8D (void);
// 0x00000026 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000027 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000028 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000029 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x0000002A System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x0000002B System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x0000002C System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002E System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000002F System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000030 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000031 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000032 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000033 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000034 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000035 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000036 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000037 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000038 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000039 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000003B System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000003C System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000003D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x0000003E System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000040 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000041 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000042 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000043 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000044 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000045 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000046 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000047 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000048 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000049 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x0000004A System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000004B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000004C System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000004D System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x0000004E System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x0000004F System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000050 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000051 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x00000052 System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000053 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000054 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000055 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x00000056 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x00000057 System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000058 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000059 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x0000005A TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x0000005B System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x0000005C System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x0000005D System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x0000005E System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005F System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::.ctor(System.Int32)
// 0x00000060 System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.IDisposable.Dispose()
// 0x00000061 System.Boolean System.Linq.Enumerable/<TakeIterator>d__25`1::MoveNext()
// 0x00000062 System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::<>m__Finally1()
// 0x00000063 TSource System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000064 System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.Reset()
// 0x00000065 System.Object System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.get_Current()
// 0x00000066 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000067 System.Collections.IEnumerator System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000068 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000069 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x0000006A System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x0000006B System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x0000006C TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000006D System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000006E System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000006F System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000070 System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000071 System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::.ctor(System.Int32)
// 0x00000072 System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::System.IDisposable.Dispose()
// 0x00000073 System.Boolean System.Linq.Enumerable/<ReverseIterator>d__79`1::MoveNext()
// 0x00000074 TSource System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000075 System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerator.Reset()
// 0x00000076 System.Object System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerator.get_Current()
// 0x00000077 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000078 System.Collections.IEnumerator System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000079 System.Void System.Linq.EmptyEnumerable`1::.cctor()
// 0x0000007A System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000007B System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x0000007C System.Boolean System.Linq.Set`1::Add(TElement)
// 0x0000007D System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x0000007E System.Void System.Linq.Set`1::Resize()
// 0x0000007F System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000080 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000081 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000082 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000083 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000084 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000085 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000086 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x00000087 System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000088 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000089 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x0000008A System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x0000008B System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000008C System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000008D System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x0000008E System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x0000008F System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000090 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000091 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000092 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000093 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000094 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000095 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000096 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000097 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000098 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000099 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEnumerable`1<T>)
// 0x0000009A System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEnumerable`1<T>,System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000009B System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000009C System.Void System.Collections.Generic.HashSet`1::CopyFrom(System.Collections.Generic.HashSet`1<T>)
// 0x0000009D System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000009E System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x0000009F System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x000000A0 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x000000A1 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x000000A2 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x000000A3 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x000000A4 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x000000A5 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x000000A6 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x000000A7 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x000000A8 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x000000A9 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x000000AA System.Void System.Collections.Generic.HashSet`1::UnionWith(System.Collections.Generic.IEnumerable`1<T>)
// 0x000000AB System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x000000AC System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x000000AD System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::get_Comparer()
// 0x000000AE System.Void System.Collections.Generic.HashSet`1::TrimExcess()
// 0x000000AF System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x000000B0 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x000000B1 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x000000B2 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x000000B3 System.Void System.Collections.Generic.HashSet`1::AddValue(System.Int32,System.Int32,T)
// 0x000000B4 System.Boolean System.Collections.Generic.HashSet`1::AreEqualityComparersEqual(System.Collections.Generic.HashSet`1<T>,System.Collections.Generic.HashSet`1<T>)
// 0x000000B5 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x000000B6 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x000000B7 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x000000B8 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x000000B9 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x000000BA System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x000000BB System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
// 0x000000BC System.Void System.Collections.Generic.ICollectionDebugView`1::.ctor(System.Collections.Generic.ICollection`1<T>)
// 0x000000BD T[] System.Collections.Generic.ICollectionDebugView`1::get_Items()
static Il2CppMethodPointer s_methodPointers[189] = 
{
	NULL,
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	Enumerable_Min_mF7108B5155FD1BC3BBD32511DCD8A0385EEEED9E,
	Enumerable_Max_mE02EED2C10C2F8F0B2DCE468C87EF3064E854A8D,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[189] = 
{
	-1,
	6887,
	6887,
	7121,
	7121,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	6799,
	6799,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[62] = 
{
	{ 0x02000005, { 92, 4 } },
	{ 0x02000006, { 96, 9 } },
	{ 0x02000007, { 107, 7 } },
	{ 0x02000008, { 116, 10 } },
	{ 0x02000009, { 128, 11 } },
	{ 0x0200000A, { 142, 9 } },
	{ 0x0200000B, { 154, 12 } },
	{ 0x0200000C, { 169, 1 } },
	{ 0x0200000D, { 170, 2 } },
	{ 0x0200000E, { 172, 12 } },
	{ 0x0200000F, { 184, 8 } },
	{ 0x02000010, { 192, 11 } },
	{ 0x02000011, { 203, 6 } },
	{ 0x02000012, { 209, 2 } },
	{ 0x02000014, { 211, 8 } },
	{ 0x02000016, { 219, 3 } },
	{ 0x02000017, { 224, 5 } },
	{ 0x02000018, { 229, 7 } },
	{ 0x02000019, { 236, 3 } },
	{ 0x0200001A, { 239, 7 } },
	{ 0x0200001B, { 246, 4 } },
	{ 0x0200001C, { 250, 34 } },
	{ 0x0200001E, { 284, 2 } },
	{ 0x0200001F, { 286, 2 } },
	{ 0x06000001, { 0, 1 } },
	{ 0x06000006, { 1, 10 } },
	{ 0x06000007, { 11, 10 } },
	{ 0x06000008, { 21, 5 } },
	{ 0x06000009, { 26, 5 } },
	{ 0x0600000A, { 31, 1 } },
	{ 0x0600000B, { 32, 2 } },
	{ 0x0600000C, { 34, 1 } },
	{ 0x0600000D, { 35, 2 } },
	{ 0x0600000E, { 37, 2 } },
	{ 0x0600000F, { 39, 1 } },
	{ 0x06000010, { 40, 1 } },
	{ 0x06000011, { 41, 2 } },
	{ 0x06000012, { 43, 1 } },
	{ 0x06000013, { 44, 2 } },
	{ 0x06000014, { 46, 3 } },
	{ 0x06000015, { 49, 2 } },
	{ 0x06000016, { 51, 4 } },
	{ 0x06000017, { 55, 4 } },
	{ 0x06000018, { 59, 3 } },
	{ 0x06000019, { 62, 4 } },
	{ 0x0600001A, { 66, 3 } },
	{ 0x0600001B, { 69, 3 } },
	{ 0x0600001C, { 72, 1 } },
	{ 0x0600001D, { 73, 1 } },
	{ 0x0600001E, { 74, 3 } },
	{ 0x0600001F, { 77, 3 } },
	{ 0x06000020, { 80, 2 } },
	{ 0x06000021, { 82, 3 } },
	{ 0x06000022, { 85, 2 } },
	{ 0x06000023, { 87, 5 } },
	{ 0x06000035, { 105, 2 } },
	{ 0x0600003A, { 114, 2 } },
	{ 0x0600003F, { 126, 2 } },
	{ 0x06000045, { 139, 3 } },
	{ 0x0600004A, { 151, 3 } },
	{ 0x0600004F, { 166, 3 } },
	{ 0x06000083, { 222, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[288] = 
{
	{ (Il2CppRGCTXDataType)3, 36421 },
	{ (Il2CppRGCTXDataType)2, 3469 },
	{ (Il2CppRGCTXDataType)3, 15047 },
	{ (Il2CppRGCTXDataType)2, 5712 },
	{ (Il2CppRGCTXDataType)2, 5011 },
	{ (Il2CppRGCTXDataType)3, 30394 },
	{ (Il2CppRGCTXDataType)2, 3653 },
	{ (Il2CppRGCTXDataType)2, 5018 },
	{ (Il2CppRGCTXDataType)3, 30450 },
	{ (Il2CppRGCTXDataType)2, 5013 },
	{ (Il2CppRGCTXDataType)3, 30406 },
	{ (Il2CppRGCTXDataType)2, 3470 },
	{ (Il2CppRGCTXDataType)3, 15048 },
	{ (Il2CppRGCTXDataType)2, 5754 },
	{ (Il2CppRGCTXDataType)2, 5023 },
	{ (Il2CppRGCTXDataType)3, 30465 },
	{ (Il2CppRGCTXDataType)2, 3677 },
	{ (Il2CppRGCTXDataType)2, 5031 },
	{ (Il2CppRGCTXDataType)3, 30711 },
	{ (Il2CppRGCTXDataType)2, 5027 },
	{ (Il2CppRGCTXDataType)3, 30577 },
	{ (Il2CppRGCTXDataType)2, 1108 },
	{ (Il2CppRGCTXDataType)3, 97 },
	{ (Il2CppRGCTXDataType)3, 98 },
	{ (Il2CppRGCTXDataType)2, 2248 },
	{ (Il2CppRGCTXDataType)3, 11224 },
	{ (Il2CppRGCTXDataType)2, 1110 },
	{ (Il2CppRGCTXDataType)3, 117 },
	{ (Il2CppRGCTXDataType)3, 118 },
	{ (Il2CppRGCTXDataType)2, 2267 },
	{ (Il2CppRGCTXDataType)3, 11232 },
	{ (Il2CppRGCTXDataType)3, 35475 },
	{ (Il2CppRGCTXDataType)2, 1124 },
	{ (Il2CppRGCTXDataType)3, 254 },
	{ (Il2CppRGCTXDataType)3, 35481 },
	{ (Il2CppRGCTXDataType)2, 1128 },
	{ (Il2CppRGCTXDataType)3, 290 },
	{ (Il2CppRGCTXDataType)2, 4382 },
	{ (Il2CppRGCTXDataType)3, 24196 },
	{ (Il2CppRGCTXDataType)3, 12252 },
	{ (Il2CppRGCTXDataType)3, 35410 },
	{ (Il2CppRGCTXDataType)2, 1114 },
	{ (Il2CppRGCTXDataType)3, 183 },
	{ (Il2CppRGCTXDataType)3, 35444 },
	{ (Il2CppRGCTXDataType)2, 1120 },
	{ (Il2CppRGCTXDataType)3, 231 },
	{ (Il2CppRGCTXDataType)2, 1411 },
	{ (Il2CppRGCTXDataType)3, 2347 },
	{ (Il2CppRGCTXDataType)3, 2348 },
	{ (Il2CppRGCTXDataType)2, 3654 },
	{ (Il2CppRGCTXDataType)3, 16161 },
	{ (Il2CppRGCTXDataType)2, 3215 },
	{ (Il2CppRGCTXDataType)2, 2557 },
	{ (Il2CppRGCTXDataType)2, 2716 },
	{ (Il2CppRGCTXDataType)2, 2867 },
	{ (Il2CppRGCTXDataType)2, 3216 },
	{ (Il2CppRGCTXDataType)2, 2558 },
	{ (Il2CppRGCTXDataType)2, 2717 },
	{ (Il2CppRGCTXDataType)2, 2868 },
	{ (Il2CppRGCTXDataType)2, 2718 },
	{ (Il2CppRGCTXDataType)2, 2869 },
	{ (Il2CppRGCTXDataType)3, 11226 },
	{ (Il2CppRGCTXDataType)2, 3217 },
	{ (Il2CppRGCTXDataType)2, 2559 },
	{ (Il2CppRGCTXDataType)2, 2719 },
	{ (Il2CppRGCTXDataType)2, 2870 },
	{ (Il2CppRGCTXDataType)2, 2720 },
	{ (Il2CppRGCTXDataType)2, 2871 },
	{ (Il2CppRGCTXDataType)3, 11227 },
	{ (Il2CppRGCTXDataType)2, 3214 },
	{ (Il2CppRGCTXDataType)2, 2715 },
	{ (Il2CppRGCTXDataType)2, 2866 },
	{ (Il2CppRGCTXDataType)2, 1863 },
	{ (Il2CppRGCTXDataType)2, 2700 },
	{ (Il2CppRGCTXDataType)2, 2701 },
	{ (Il2CppRGCTXDataType)2, 2863 },
	{ (Il2CppRGCTXDataType)3, 11223 },
	{ (Il2CppRGCTXDataType)2, 2699 },
	{ (Il2CppRGCTXDataType)2, 2862 },
	{ (Il2CppRGCTXDataType)3, 11222 },
	{ (Il2CppRGCTXDataType)2, 2556 },
	{ (Il2CppRGCTXDataType)2, 2713 },
	{ (Il2CppRGCTXDataType)2, 2714 },
	{ (Il2CppRGCTXDataType)2, 2865 },
	{ (Il2CppRGCTXDataType)3, 11225 },
	{ (Il2CppRGCTXDataType)2, 2555 },
	{ (Il2CppRGCTXDataType)3, 35383 },
	{ (Il2CppRGCTXDataType)3, 9733 },
	{ (Il2CppRGCTXDataType)2, 1962 },
	{ (Il2CppRGCTXDataType)2, 2703 },
	{ (Il2CppRGCTXDataType)2, 2864 },
	{ (Il2CppRGCTXDataType)2, 2994 },
	{ (Il2CppRGCTXDataType)3, 15049 },
	{ (Il2CppRGCTXDataType)3, 15051 },
	{ (Il2CppRGCTXDataType)2, 812 },
	{ (Il2CppRGCTXDataType)3, 15050 },
	{ (Il2CppRGCTXDataType)3, 15059 },
	{ (Il2CppRGCTXDataType)2, 3473 },
	{ (Il2CppRGCTXDataType)2, 5014 },
	{ (Il2CppRGCTXDataType)3, 30407 },
	{ (Il2CppRGCTXDataType)3, 15060 },
	{ (Il2CppRGCTXDataType)2, 2780 },
	{ (Il2CppRGCTXDataType)2, 2908 },
	{ (Il2CppRGCTXDataType)3, 11240 },
	{ (Il2CppRGCTXDataType)3, 35338 },
	{ (Il2CppRGCTXDataType)2, 5028 },
	{ (Il2CppRGCTXDataType)3, 30578 },
	{ (Il2CppRGCTXDataType)3, 15052 },
	{ (Il2CppRGCTXDataType)2, 3472 },
	{ (Il2CppRGCTXDataType)2, 5012 },
	{ (Il2CppRGCTXDataType)3, 30395 },
	{ (Il2CppRGCTXDataType)3, 11239 },
	{ (Il2CppRGCTXDataType)3, 15053 },
	{ (Il2CppRGCTXDataType)3, 35337 },
	{ (Il2CppRGCTXDataType)2, 5024 },
	{ (Il2CppRGCTXDataType)3, 30466 },
	{ (Il2CppRGCTXDataType)3, 15066 },
	{ (Il2CppRGCTXDataType)2, 3474 },
	{ (Il2CppRGCTXDataType)2, 5019 },
	{ (Il2CppRGCTXDataType)3, 30451 },
	{ (Il2CppRGCTXDataType)3, 16222 },
	{ (Il2CppRGCTXDataType)3, 7675 },
	{ (Il2CppRGCTXDataType)3, 11241 },
	{ (Il2CppRGCTXDataType)3, 7674 },
	{ (Il2CppRGCTXDataType)3, 15067 },
	{ (Il2CppRGCTXDataType)3, 35339 },
	{ (Il2CppRGCTXDataType)2, 5032 },
	{ (Il2CppRGCTXDataType)3, 30712 },
	{ (Il2CppRGCTXDataType)3, 15080 },
	{ (Il2CppRGCTXDataType)2, 3476 },
	{ (Il2CppRGCTXDataType)2, 5030 },
	{ (Il2CppRGCTXDataType)3, 30580 },
	{ (Il2CppRGCTXDataType)3, 15081 },
	{ (Il2CppRGCTXDataType)2, 2783 },
	{ (Il2CppRGCTXDataType)2, 2911 },
	{ (Il2CppRGCTXDataType)3, 11245 },
	{ (Il2CppRGCTXDataType)3, 11244 },
	{ (Il2CppRGCTXDataType)2, 5016 },
	{ (Il2CppRGCTXDataType)3, 30409 },
	{ (Il2CppRGCTXDataType)3, 35348 },
	{ (Il2CppRGCTXDataType)2, 5029 },
	{ (Il2CppRGCTXDataType)3, 30579 },
	{ (Il2CppRGCTXDataType)3, 15073 },
	{ (Il2CppRGCTXDataType)2, 3475 },
	{ (Il2CppRGCTXDataType)2, 5026 },
	{ (Il2CppRGCTXDataType)3, 30468 },
	{ (Il2CppRGCTXDataType)3, 11243 },
	{ (Il2CppRGCTXDataType)3, 11242 },
	{ (Il2CppRGCTXDataType)3, 15074 },
	{ (Il2CppRGCTXDataType)2, 5015 },
	{ (Il2CppRGCTXDataType)3, 30408 },
	{ (Il2CppRGCTXDataType)3, 35347 },
	{ (Il2CppRGCTXDataType)2, 5025 },
	{ (Il2CppRGCTXDataType)3, 30467 },
	{ (Il2CppRGCTXDataType)3, 15087 },
	{ (Il2CppRGCTXDataType)2, 3477 },
	{ (Il2CppRGCTXDataType)2, 5034 },
	{ (Il2CppRGCTXDataType)3, 30714 },
	{ (Il2CppRGCTXDataType)3, 16223 },
	{ (Il2CppRGCTXDataType)3, 7677 },
	{ (Il2CppRGCTXDataType)3, 11247 },
	{ (Il2CppRGCTXDataType)3, 11246 },
	{ (Il2CppRGCTXDataType)3, 7676 },
	{ (Il2CppRGCTXDataType)3, 15088 },
	{ (Il2CppRGCTXDataType)2, 5017 },
	{ (Il2CppRGCTXDataType)3, 30410 },
	{ (Il2CppRGCTXDataType)3, 35349 },
	{ (Il2CppRGCTXDataType)2, 5033 },
	{ (Il2CppRGCTXDataType)3, 30713 },
	{ (Il2CppRGCTXDataType)3, 11236 },
	{ (Il2CppRGCTXDataType)3, 11237 },
	{ (Il2CppRGCTXDataType)3, 11251 },
	{ (Il2CppRGCTXDataType)3, 257 },
	{ (Il2CppRGCTXDataType)3, 256 },
	{ (Il2CppRGCTXDataType)2, 2772 },
	{ (Il2CppRGCTXDataType)2, 2902 },
	{ (Il2CppRGCTXDataType)3, 11238 },
	{ (Il2CppRGCTXDataType)2, 2794 },
	{ (Il2CppRGCTXDataType)2, 2930 },
	{ (Il2CppRGCTXDataType)3, 259 },
	{ (Il2CppRGCTXDataType)2, 1020 },
	{ (Il2CppRGCTXDataType)2, 1125 },
	{ (Il2CppRGCTXDataType)3, 255 },
	{ (Il2CppRGCTXDataType)3, 258 },
	{ (Il2CppRGCTXDataType)3, 292 },
	{ (Il2CppRGCTXDataType)2, 2775 },
	{ (Il2CppRGCTXDataType)2, 2904 },
	{ (Il2CppRGCTXDataType)3, 294 },
	{ (Il2CppRGCTXDataType)2, 810 },
	{ (Il2CppRGCTXDataType)2, 1129 },
	{ (Il2CppRGCTXDataType)3, 291 },
	{ (Il2CppRGCTXDataType)3, 293 },
	{ (Il2CppRGCTXDataType)3, 185 },
	{ (Il2CppRGCTXDataType)2, 4574 },
	{ (Il2CppRGCTXDataType)3, 27883 },
	{ (Il2CppRGCTXDataType)2, 2766 },
	{ (Il2CppRGCTXDataType)2, 2899 },
	{ (Il2CppRGCTXDataType)3, 27884 },
	{ (Il2CppRGCTXDataType)3, 187 },
	{ (Il2CppRGCTXDataType)2, 805 },
	{ (Il2CppRGCTXDataType)2, 1115 },
	{ (Il2CppRGCTXDataType)3, 184 },
	{ (Il2CppRGCTXDataType)3, 186 },
	{ (Il2CppRGCTXDataType)2, 1412 },
	{ (Il2CppRGCTXDataType)3, 2349 },
	{ (Il2CppRGCTXDataType)2, 807 },
	{ (Il2CppRGCTXDataType)2, 1121 },
	{ (Il2CppRGCTXDataType)3, 232 },
	{ (Il2CppRGCTXDataType)3, 233 },
	{ (Il2CppRGCTXDataType)2, 5766 },
	{ (Il2CppRGCTXDataType)2, 1864 },
	{ (Il2CppRGCTXDataType)3, 9774 },
	{ (Il2CppRGCTXDataType)2, 1980 },
	{ (Il2CppRGCTXDataType)2, 5873 },
	{ (Il2CppRGCTXDataType)3, 27880 },
	{ (Il2CppRGCTXDataType)3, 27881 },
	{ (Il2CppRGCTXDataType)2, 3009 },
	{ (Il2CppRGCTXDataType)3, 27882 },
	{ (Il2CppRGCTXDataType)2, 707 },
	{ (Il2CppRGCTXDataType)2, 1118 },
	{ (Il2CppRGCTXDataType)3, 211 },
	{ (Il2CppRGCTXDataType)3, 24179 },
	{ (Il2CppRGCTXDataType)2, 4383 },
	{ (Il2CppRGCTXDataType)3, 24197 },
	{ (Il2CppRGCTXDataType)2, 1414 },
	{ (Il2CppRGCTXDataType)3, 2350 },
	{ (Il2CppRGCTXDataType)3, 24185 },
	{ (Il2CppRGCTXDataType)3, 7635 },
	{ (Il2CppRGCTXDataType)2, 851 },
	{ (Il2CppRGCTXDataType)3, 24180 },
	{ (Il2CppRGCTXDataType)2, 4379 },
	{ (Il2CppRGCTXDataType)3, 2593 },
	{ (Il2CppRGCTXDataType)2, 1466 },
	{ (Il2CppRGCTXDataType)2, 1909 },
	{ (Il2CppRGCTXDataType)3, 7644 },
	{ (Il2CppRGCTXDataType)3, 24181 },
	{ (Il2CppRGCTXDataType)3, 7630 },
	{ (Il2CppRGCTXDataType)3, 7631 },
	{ (Il2CppRGCTXDataType)3, 7629 },
	{ (Il2CppRGCTXDataType)3, 7632 },
	{ (Il2CppRGCTXDataType)2, 1905 },
	{ (Il2CppRGCTXDataType)2, 5829 },
	{ (Il2CppRGCTXDataType)3, 11234 },
	{ (Il2CppRGCTXDataType)3, 7634 },
	{ (Il2CppRGCTXDataType)2, 2665 },
	{ (Il2CppRGCTXDataType)3, 7633 },
	{ (Il2CppRGCTXDataType)2, 2561 },
	{ (Il2CppRGCTXDataType)2, 5757 },
	{ (Il2CppRGCTXDataType)2, 2738 },
	{ (Il2CppRGCTXDataType)2, 2876 },
	{ (Il2CppRGCTXDataType)3, 9755 },
	{ (Il2CppRGCTXDataType)2, 1973 },
	{ (Il2CppRGCTXDataType)3, 11957 },
	{ (Il2CppRGCTXDataType)3, 11958 },
	{ (Il2CppRGCTXDataType)2, 2515 },
	{ (Il2CppRGCTXDataType)3, 11961 },
	{ (Il2CppRGCTXDataType)2, 2515 },
	{ (Il2CppRGCTXDataType)3, 11962 },
	{ (Il2CppRGCTXDataType)2, 2564 },
	{ (Il2CppRGCTXDataType)3, 11966 },
	{ (Il2CppRGCTXDataType)3, 11970 },
	{ (Il2CppRGCTXDataType)3, 11969 },
	{ (Il2CppRGCTXDataType)2, 5871 },
	{ (Il2CppRGCTXDataType)3, 11960 },
	{ (Il2CppRGCTXDataType)3, 11959 },
	{ (Il2CppRGCTXDataType)3, 11967 },
	{ (Il2CppRGCTXDataType)2, 3003 },
	{ (Il2CppRGCTXDataType)3, 11964 },
	{ (Il2CppRGCTXDataType)3, 36251 },
	{ (Il2CppRGCTXDataType)2, 1913 },
	{ (Il2CppRGCTXDataType)3, 7663 },
	{ (Il2CppRGCTXDataType)1, 2660 },
	{ (Il2CppRGCTXDataType)2, 5772 },
	{ (Il2CppRGCTXDataType)3, 11963 },
	{ (Il2CppRGCTXDataType)1, 5772 },
	{ (Il2CppRGCTXDataType)1, 3003 },
	{ (Il2CppRGCTXDataType)2, 5871 },
	{ (Il2CppRGCTXDataType)2, 5772 },
	{ (Il2CppRGCTXDataType)2, 2740 },
	{ (Il2CppRGCTXDataType)2, 2878 },
	{ (Il2CppRGCTXDataType)3, 11968 },
	{ (Il2CppRGCTXDataType)3, 11965 },
	{ (Il2CppRGCTXDataType)3, 11971 },
	{ (Il2CppRGCTXDataType)2, 602 },
	{ (Il2CppRGCTXDataType)3, 7678 },
	{ (Il2CppRGCTXDataType)2, 822 },
	{ (Il2CppRGCTXDataType)2, 2567 },
	{ (Il2CppRGCTXDataType)2, 5774 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	189,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	62,
	s_rgctxIndices,
	288,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
