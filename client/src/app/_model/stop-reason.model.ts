

export interface StopReason {
  workOrderNumber: number|string
  resultKeyValues: Map<string, number>[],
  totalWorkOrder: number
}
