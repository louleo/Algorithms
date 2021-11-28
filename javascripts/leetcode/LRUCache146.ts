class LinkedListNode{
    value: number;
    key: number;
    prev: LinkedListNode;
    next: LinkedListNode;
}

class LRUCache {
    capacity: number;
    cache: any;
    head: LinkedListNode;
    tail: LinkedListNode;

    constructor(capacity: number) {
        this.capacity = capacity;
        this.cache = new Map();
        this.head = new LinkedListNode();
        this.tail = new LinkedListNode();
        this.head.next = this.tail;
        this.tail.prev = this.head;
    }

    get(key: number): number {
        const node = this.cache.get(key);
        if(node){
            this.remove(node);
            this.addToTail(node);
            return node.value;
        }
        return -1;
    }

    put(key: number, value: number): void {
        let node = this.cache.get(key);
        if(node){
            node.value = value;
            this.remove(node);
            this.addToTail(node);
        }else{
            node = new LinkedListNode();
            node.value = value;
            node.key = key;
            this.cache.set(key, node);
            this.addToTail(node);
            while(this.cache.size > this.capacity){
                this.cache.delete(this.head.next.key);
                this.remove(this.head.next);
            }
        }
    }

    remove(node: LinkedListNode): void{
        node.next.prev = node.prev;
        node.prev.next = node.next;
        node.prev = null;
        node.next = null;
    }

    addToTail(node: LinkedListNode): void{
        node.prev = this.tail.prev;
        node.prev.next = node;
        node.next = this.tail;
        node.next.prev = node;
    }
}
