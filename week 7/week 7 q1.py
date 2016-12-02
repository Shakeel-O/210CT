class graph():
    def __init__(self, graph_list):                 #Graph is being initalisied
        if graph_list == None:                      
            graph_list = {}                         
        self.graph_list = graph_list
        

    def vertex(self):
        return list(self.graph_list.keys())

    def links_create(self):
        links = []

        for vertex in self.graph_list:
            for neighbour in self.graph_list[vertex]:
                if {neighbour, vertex} not in links:
                    links.append({vertex, neighbour})
        return links

    def links(self):
        return self.links_create()


    def add_vertex(self, vertex):
        if vertex not in self.graph_list:
            self.graph_list[vertex] = []

    def add_edge(self, edge):
        edge = set(edge)
        (vertex1, vertex2) = tuple(edge)
        if vertex1 in self.graph_list: # creates an undirected link by connectiong from both sides
            self.graph_list[vertex1].append(vertex2)
            self.graph_list[vertex2].append(vertex1)
        else:
            self.graph_list[vertex1] = [vertex2]
            self.graph_list[vertex2] = [vertex1]

g = {}
graph = graph(g)
graph.add_vertex(1)
graph.add_vertex(2)
graph.add_vertex(3)
graph.add_vertex(4)
graph.add_vertex(5)
graph.add_vertex(6)
print(graph.vertex())

graph.add_edge({1, 2})
graph.add_edge({1, 3})
graph.add_edge({1, 6})
graph.add_edge({2, 3})
graph.add_edge({2, 4})
graph.add_edge({3, 4})
graph.add_edge({3, 6})
graph.add_edge({4, 5})
graph.add_edge({5, 6})
vertexs = graph.vertex()
print(graph.links())
