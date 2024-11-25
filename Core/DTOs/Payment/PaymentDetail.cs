﻿namespace Core.DTOs.Payment;

public class PaymentDetail
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public DateTime ApprovedDate { get; set; }
    public decimal RequestedAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal Revenue { get; set; }
    public ushort Months { get; set; }
    public string LoanType { get; set; } = string.Empty;
    public float InterestRate { get; set; }
    public int CompletePayments { get; set; }
    public int UncompletePayments { get; set; }
    public DateTime? NextDueDate { get; set; }  // Próxima fecha de vencimiento
    public string PaymentStatus { get; set; } = string.Empty;  // Mensaje si todas las cuotas están pagadas
}