from typing import List


def compareList(list1: List[int], list2: List[int], sort = False) -> bool:
    if sort:
        list1.sort()
        list2.sort()
    if len(list1) != len(list2):
        print(list1)
        print(list2)
        return False
    for i in range(0, len(list1) -1):
        if list1[i] != list2[i]:
            print(list1)
            print(list2)
            return False
    return True