   M S B A M L   `   `   `  ����C  ?EF40Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:EF40Data;assembly=EF40DataEF40Data  5   �    
WPFBinding   WPFBinding.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   C   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   7my(clr-namespace:EF40Data;assembly=EF40Data     6�   -   5          � Title$  Window1��5   	   $	��300��6   $	��300��6&    � 	Resources 5         salesOrderHeaderViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5	   
   &   System.Windows.Controls.DataGrid  -   5        $��salesOrderHeaderDataGrid��5	   �      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6N   $
��Left=�6[   $��	10,56,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��Top=�6�   $	��400��6  ��6v   ��    Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        accountNumberColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Account Number��5   i      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� 
 �� Path$
 AccountNumber�6�     5      -   5        billToAddressIDColumn��$ Bill To Address ID��5   m   $ SizeToHeader 6�   	 6D   �� $
 BillToAddressID�6�     5      -   5        commentColumn��$ Comment��5   ]   $ SizeToHeader 6n   	 6<   �� $
 Comment�6n     5      -   5        contactIDColumn��$ 
Contact ID��5   a   $ SizeToHeader 6u   	 6>   �� $
 	ContactID�6u     5      -   5         creditCardApprovalCodeColumn��$ Credit Card Approval Code��5   {   $ SizeToHeader 6�   	 6K   �� $
 CreditCardApprovalCode�6�     5      -   5        creditCardIDColumn��$ Credit Card ID��5   g   $ SizeToHeader 6   	 6A   �� $
 CreditCardID�6     5      -	   5        currencyRateIDColumn��$ Currency Rate ID��5   k   $ SizeToHeader 6�   	 6C   �� $
 CurrencyRateID�6�     5      -
   5        customerIDColumn��$ Customer ID��5   c   $ SizeToHeader 6x   	 6?   �� $
 
CustomerID�6x   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        dueDateColumn��$ Due Date��5   @   $ SizeToHeader 6R      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� $
 DueDate�5      5        5      -   5        freightColumn��$ Freight��5   ]   $ SizeToHeader 6n   	 6<   �� $
 Freight�6n     5      -   5        modifiedDateColumn��$ Modified Date��5   E   $ SizeToHeader 6\    5      �� 5      .R�5         6)   �� $
 ModifiedDate�5      5!      4  .System.Windows.Controls.DataGridCheckBoxColumn  5"      -   5        onlineOrderFlagColumn��$ Online Order Flag��5"   q   $ SizeToHeader 6�   	 6H   �� $
 OnlineOrderFlag�6�     5#      -   5        orderDateColumn��$ 
Order Date��5#   B   $ SizeToHeader 6V    5$      �� 5%      .R�5&         6)   �� $
 	OrderDate�5'      5)        5*      -   5        purchaseOrderNumberColumn��$ Purchase Order Number��5*   u   $ SizeToHeader 6�   	 6H   �� $
 PurchaseOrderNumber�6�     5+      -   5        revisionNumberColumn��$ Revision Number��5+   k   $ SizeToHeader 6�   	 6C   �� $
 RevisionNumber�6�     5,      -   5        rowguidColumn��$ rowguid��5,   ]   $ SizeToHeader 6n   	 6<   �� $
 rowguid�6n     5-      -   5        salesOrderIDColumn��$ Sales Order ID��5-   g   $ SizeToHeader 6   	 6A   �� $
 SalesOrderID�6     5.      -   5        salesOrderNumberColumn��$ Sales Order Number��5.   o   $ SizeToHeader 6�   	 6E   �� $
 SalesOrderNumber�6�     5/      -   5        salesPersonIDColumn��$ Sales Person ID��5/   i   $ SizeToHeader 6�   	 6B   �� $
 SalesPersonID�6�     50      -   5        shipDateColumn��$ 	Ship Date��50   A   $ SizeToHeader 6T    51      �� 52      .R�53         6)   �� $
 ShipDate�54      56        57      -   5        shipMethodIDColumn��$ Ship Method ID��57   g   $ SizeToHeader 6   	 6A   �� $
 ShipMethodID�6     58      -   5        shipToAddressIDColumn��$ Ship To Address ID��58   m   $ SizeToHeader 6�   	 6D   �� $
 ShipToAddressID�6�     59      -   5        statusColumn��$ Status��59   [   $ SizeToHeader 6k   	 6;   �� $
 Status�6k     5:      -   5        subTotalColumn��$ 	Sub Total��5:   _   $ SizeToHeader 6r   	 6=   �� $
 SubTotal�6r     5;      -   5        taxAmtColumn��$ Tax Amt��5;   [   $ SizeToHeader 6l   	 6;   �� $
 TaxAmt�6l     5<      -   5        territoryIDColumn��$ Territory ID��5<   e   $ SizeToHeader 6{   	 6@   �� $
 TerritoryID�6{     5=      -   5        totalDueColumn��$ 	Total Due��5=   _   $ SizeToHeader 6r   	 6=   �� $
 TotalDue�6r   5?      5@      5A      