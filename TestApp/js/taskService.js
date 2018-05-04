var PRIORITY_HIGHEST = 'HIGHEST';
var PRIORITY_HIGH = 'HIGH';
var PRIORITY_MEDIUM = 'MEDIUM';
var PRIORITY_LOW = 'LOW';
var PRIORITY_TRIVIAL = 'TRIVIAL';
// STATUS
var TYPE_TODO = 'TODO';
var TYPE_INPROGRESS = 'INPROGRESS';
var TYPE_DONE = 'DONE';
// TITLES
var TITLE_TODO = 'To do';
var TITLE_INPROGRESS = 'In Progress';
var TITLE_DONE = 'Done';
// TASK
var CLASS_TASK = 'taskCard';
var CLASS_COLUMN = 'boardColumn';
function getTask() {
    var data = {
        tasks: [{
            id: 'REACT-1',
            priority: PRIORITY_HIGHEST,
            title: 'Read WebPack documentation',
            epicLink: 'React buidings',
            status: TYPE_DONE,
            points: 3
        }, {
            id: 'REACT-2',
            priority: PRIORITY_HIGHEST,
            title: 'Install dependencies',
            epicLink: 'React buidings',
            status: TYPE_DONE,
            points: 3
        }, {
            id: 'REACT-3',
            priority: PRIORITY_HIGH,
            title: 'Try Hello world',
            epicLink: 'React buidings',
            status: TYPE_DONE
        }, {
            id: 'REACT-4',
            priority: PRIORITY_MEDIUM,
            title: 'Create some little components',
            epicLink: 'React buidings',
            status: TYPE_INPROGRESS
        }, {
            id: 'REACT-5',
            priority: PRIORITY_MEDIUM,
            title: 'Create App with react-router',
            epicLink: 'React buidings',
            status: TYPE_TODO
        }, {
            id: 'REACT-6',
            priority: PRIORITY_MEDIUM,
            title: 'Practise styled-components (react library)',
            epicLink: 'React buidings',
            status: TYPE_TODO
        }, {
            id: 'REACT-7',
            priority: PRIORITY_LOW,
            title: 'Read Redux documentation',
            epicLink: 'React buidings',
            status: TYPE_TODO
        }, {
            id: 'REACT-8',
            priority: PRIORITY_LOW,
            title: 'Do a little project with ReduxJS',
            epicLink: 'React buidings',
            status: TYPE_TODO
        }]
    };
    return data;
}