import { VehicleModuleModule } from './vehicle-module.module';

describe('VehicleModuleModule', () => {
  let vehicleModuleModule: VehicleModuleModule;

  beforeEach(() => {
    vehicleModuleModule = new VehicleModuleModule();
  });

  it('should create an instance', () => {
    expect(vehicleModuleModule).toBeTruthy();
  });
});
