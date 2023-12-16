import { CustomerEntity } from './customer.model';

describe('Customer', () => {
  it('should create an instance', () => {
    expect(new CustomerEntity(1, "firstName", "lastName")).toBeTruthy();
  });
});
