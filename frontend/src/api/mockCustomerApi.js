import delay from './delay';

// This file mocks a web API by working with the hard-coded data below.
// It uses setTimeout to simulate the delay of an AJAX call.
// All calls return promises.
const customers = [
  {
    id: 1,
    companyName: "Test Company",
    websiteUrl: "test.com",
    industry: 1,
    enterpriseClient: false,
    primaryContactId: 1,
    contacts: [
      {
        id: 1,
        firstName: "Tom",
        lastName: "Wilson",
        email: "twilson@gmailcom",
        phoneNumber: "1234567834",
        customerId: 1
      }
    ]
  },
  {
    id: 2,
    companyName: "verilog",
    websiteUrl: "verilog.com",
    industry: 1,
    enterpriseClient: false,
    primaryContactId: 2,
    contacts: [
      {
        id: 2,
        firstName: "Lance",
        lastName: "Vance",
        email: "lvance@gmailcom",
        phoneNumber: "3425678964",
        customerId: 2
      }
    ]
  },
  {
    id: 3,
    companyName: "xilinx",
    websiteUrl: "xilinx.com",
    industry: 2,
    enterpriseClient: false,
    primaryContactId: 3,
    contacts: [
      {
        id: 3,
        firstName: "Q",
        lastName: "Fray",
        email: "qfray@gmailcom",
        phoneNumber: "3457689764",
        customerId: 3
      }
    ]
  }
];

function replaceAll(str, find, replace) {
  return str.replace(new RegExp(find, 'g'), replace);
}

//This would be performed on the server in a real app. Just stubbing in.
const generateId = (course) => {
  return replaceAll(course.title, ' ', '-');
};

class CustomerApi {
  static getAllCustomers() {
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        resolve(Object.assign([], customers));
      }, delay);
    });
  }

  static saveCourse(course) {
    course = Object.assign({}, course); // to avoid manipulating object passed in.
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        // Simulate server-side validation
        const minCourseTitleLength = 1;
        if (course.title.length < minCourseTitleLength) {
          reject(`Title must be at least ${minCourseTitleLength} characters.`);
        }

        if (course.id) {
          const existingCourseIndex = customers.findIndex(a => a.id == course.id);
          customers.splice(existingCourseIndex, 1, course);
        } else {
          //Just simulating creation here.
          //The server would generate ids and watchHref's for new customers in a real app.
          //Cloning so copy returned is passed by value rather than by reference.
          course.id = generateId(course);
          course.watchHref = `http://www.pluralsight.com/courses/${course.id}`;
          customers.push(course);
        }

        resolve(course);
      }, delay);
    });
  }

  static deleteCourse(courseId) {
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        const indexOfCourseToDelete = customers.findIndex(course => {
          course.id == courseId;
        });
        customers.splice(indexOfCourseToDelete, 1);
        resolve();
      }, delay);
    });
  }
}

export default CustomerApi;