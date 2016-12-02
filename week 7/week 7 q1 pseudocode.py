CLASS GRAPH():
    __init__(, GRAPH_LIST):
        if GRAPH_LIST == None:
            GRAPH_LIST <- {}
        GRAPH_LIST <- GRAPH_LIST
        
    VERTEX():
        RETURN list(GRAPH_LIST.keys())

    LINKS_CREATE():
        LINKS <- []
        for VERTEX in GRAPH_LIST:
            for NEIGHBOUR in GRAPH_LIST[VERTEX]:
                if {neighbour, VERTEX} not in LINKS:
                    LINKS.append({VERTEX,NEIGHBOUR})
        RETURN LINKS

    LINKS():
        RETURN LINKS_CREATE()

    ADD_VERTEX(, VERTEX):
        if VERTEX not in GRAPH_LIST:
            GRAPH_LIST[VERTEX] <- []

    ADD_EDGE(, EDGE):
        EDGE <- set(EDGE)
        (VERTEX1, VERTEX2) <- tuple(EDGE)
        if VERTEX1 in GRAPH_LIST:
            GRAPH_LIST[VERTEX1].append(VERTEX2)
            GRAPH_LIST[VERTEX2].append(VERTEX1)
        else:
            GRAPH_LIST[VERTEX1] <- [VERTEX2]
            GRAPH_LIST[VERTEX2] <- [VERTEX1]

g <- {}
VERTEXs <- GRAPH.VERTEX()
print(GRAPH.LINKS())
