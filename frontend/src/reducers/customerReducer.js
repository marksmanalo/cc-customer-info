import * as types from '../actions/actionTypes';

export default function customerReducer(state = {}, action) {

  const customers = 
    {
      id: 1,
      companyName: "test company",
      websiteUrl: "test@gmail.com",
      industry: 1,
      enterpriseClient: true,
      primaryContactId: 2,
      contacts: [
        {
          id: 1,
          firstName: "bob",
          lastName: "jones",
          email: "bjones@gmail.com",
          phoneNumber: "1234567897",
          customerId: 1
        }
      ]
    }    
  ;

  switch (action.type) {
    case types.LOAD_CUSTOMERS:
      return [...state,
        customers
      ];
    default:
      return state;
  }
}