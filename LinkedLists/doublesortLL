using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the sortedInsert function below.

    /*
     * For your reference:
     *
     * DoublyLinkedListNode {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */
    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data) 
    {
        DoublyLinkedListNode temp = head;
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);

        bool check = false;


        while (check != true) 
        {
            
                        if (head.next == null && (head.data < newNode.data || head.data == newNode.data))
            {
                head.next = newNode;
                newNode.prev = head;
                check = true;
            }
            else if (head.next == null && (head.data > newNode.data || head.data == newNode.data))
            {
                newNode.next = head;
                head.prev = newNode;
                temp = newNode;
                check = true;
            }

            else if (head.data > newNode.data && head.prev == null)
            {
                newNode.next = head;
                head.prev = newNode;
                temp = newNode;
                check = true;
            }
            
            
            else if (head.next.data > newNode.data)
            {
                newNode.next = head.next;
                head.next.prev = newNode;
                head.next = newNode;
                newNode.prev = head;
                check = true;
            }
            else 
            {
                head = head.next;
            }


        } 

        return temp;
    }

    static void Main(string[] args) {
