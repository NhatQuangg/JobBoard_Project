1. Components: container UI components reuse
2. Context: share state global / behavior (auth) between component
3. Helpers: container standard utility functions use many where
4. Models: define datatype
5. Services: call http API
5. Pages: route level components (page) 
6. Routes: manage routing and protect route
 
** Activity Stream:

App start (index.tsx) -> Pages -> Components call Services -> ...
